namespace Warcraft.Modules {

    using TState = WarcraftState;
    
    /// <summary>
    /// We need to implement our own StatesHistoryModule class without any logic just to catch your State type into ECS.StatesHistory
    /// You can use some overrides to setup history config for your project
    /// </summary>
    public class StatesHistoryModule : ME.ECS.StatesHistory.StatesHistoryModule<TState> {

        protected override uint GetQueueCapacity() {

            // Here you can set up history states capacity
            return 10u;

        }

        protected override uint GetTicksPerState() {

            // Every N ticks network module should clone current world's state 
            return 20u;

        }

    }

}