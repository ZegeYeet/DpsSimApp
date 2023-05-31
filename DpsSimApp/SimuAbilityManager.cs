
using System.Text;
using System;


//responsible for managing the ability queue and abilities in the queue

namespace DpsSimulator
{
    class SimuAbilityManager
    {
        AbilitiesContainer abilContainer;
        int[] abilityQueue;//holds ability IDs
        int sizeOfQueue;
        bool checksForCost = false;
        CombatResourceManager combatResourceManager;
        public SimuAbilityManager(int queueSize, AbilitiesContainer newContainer, CombatResourceManager newResourceManager, int[] abilityIDsToAdd)
        {
            abilityQueue = new int[queueSize+1];
            sizeOfQueue=0;
            Console.WriteLine("empty ability queue initialized");

            combatResourceManager = newResourceManager;

            abilContainer = newContainer; 
            for (int i = 0; i < abilityIDsToAdd.Length; i++)
            {
                AddAbilityToQueue(abilityIDsToAdd[i]);
            }
            Console.WriteLine("abilities loaded into priority queue.");

            CheckQueueOrder();
        }

        public void SetForCost()
        {
            checksForCost = true;
        }
 
        public void CallForAbility(SimuCooldownManager cooldownManager, float currentMS)
        {
            if (abilContainer == null)
            {
                Console.WriteLine("abilities container is invalid.");
                return;
            }

            if (sizeOfQueue == 0)
            {
                return;
            }

            if (checksForCost)
            {
                if (!combatResourceManager.SpendCombatResources(abilContainer.GetAbilityCost(abilityQueue[1])))
                {
                    return;
                }
            }

            abilContainer.UseAbility(abilityQueue[1], currentMS);
            PutAbilityOnCooldown(cooldownManager, 1, abilContainer.GetAbilityGCD(abilityQueue[1]), abilContainer.GetAbilityCooldown(abilityQueue[1]));
            
        }

        public int GetFirstAbility()
        {
            if(sizeOfQueue == 0)
                return -1;
            else
                return abilityQueue[1];
        }

        //the low the ability id the higher the priority
        public void AddAbilityToQueue(int abilityID)
        {
            if (sizeOfQueue < 0)
            {
                Console.WriteLine("Initialize queue before adding to it.");
                return;
            }

            if (sizeOfQueue == abilityQueue.Length)
            {
                Console.WriteLine("Queue is full. Not adding to it.");
                CheckQueueOrder();
                return;
            }
            
            abilityQueue[sizeOfQueue+1] = abilityID;
            sizeOfQueue++;
            PrioritizeFromNewAbility(sizeOfQueue);
          
        }

        //sorts queue to make sure added ability is correctly placed in the queue
        public void PrioritizeFromNewAbility(int index)
        {
            int queueParent = index / 2;

            if (index <= 1)//already at front of queue
            {
                return;
            }

            //if current Id should be higher prio then swap forward with parent
            if (abilityQueue[index] < abilityQueue[queueParent])
            {
                int movingUp = abilityQueue[index];
                abilityQueue[index] = abilityQueue[queueParent];
                abilityQueue[queueParent] = movingUp;
            }

            PrioritizeFromNewAbility(queueParent);
        }

        //prints all IDs in queue
        public void CheckQueueOrder()
        {
            StringBuilder queueString = new StringBuilder();
            queueString.Append("All IDs in the ability queue: ");
            for (int i = 1; i <= sizeOfQueue; i++)//root is always 0 value at 0 index
            {
                queueString.Append($"{abilityQueue[i] } ");
            }
            Console.WriteLine(queueString);
        }

        //removes from ability queue and puts into cooldown queue
        void PutAbilityOnCooldown(SimuCooldownManager cooldownManager, int abilityIndex, float abilityGCD, float abilityCooldown)
        {
            if (sizeOfQueue == 0)
            {
                Console.WriteLine("No abilities to put on cooldown.");
                return;
            }

            //add to cooldown queue
            cooldownManager.AddCooldownToQueue(abilityQueue[1], abilityGCD, abilityCooldown, this);
            

            //remove from the ability queue
            RemoveAbility();
        }

        //removes first ability from queue and sort queue again
        void RemoveAbility()
        {
            if (sizeOfQueue == 0)
            {
                Console.WriteLine("No abilities to remove.");
            }

            abilityQueue[1] = abilityQueue[sizeOfQueue];
            sizeOfQueue--;
            PrioritizeQueueFromStart(1);

        }

        void PrioritizeQueueFromStart(int index)
        {
            int leftChild = index * 2;//built in avl tree so this is the left child
            int rightChild = (index * 2) + 1;//built in avl tree so this is the right child
            int smallestChild = 0;

            //no children
            if (sizeOfQueue < leftChild)
            {
                return;
            }
            else if (sizeOfQueue == leftChild) //only left child
            {
                //swap places with child if child is smaller
                if (abilityQueue[index] > abilityQueue[leftChild])
                {
                    int movingDown = abilityQueue[index];
                    abilityQueue[index] = abilityQueue[leftChild];
                    abilityQueue[leftChild] = movingDown;
                }
                return;
            }
            else //has both children
            {
                //get smallest child first
                smallestChild = leftChild;
                if (abilityQueue[rightChild] < abilityQueue[leftChild])
                {
                    smallestChild = rightChild;
                }
                
                //if parent greater than smallest then swap
                if (abilityQueue[index] > abilityQueue[smallestChild])
                {
                    int movingDown = abilityQueue[index];
                    abilityQueue[index] = abilityQueue[smallestChild];
                    abilityQueue[smallestChild] = movingDown;
                }

                PrioritizeQueueFromStart(smallestChild);
            }
        }
    }
}