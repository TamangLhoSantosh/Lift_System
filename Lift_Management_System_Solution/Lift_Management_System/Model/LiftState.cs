using Lift_Management_System.Enum;

namespace Lift_Management_System.Helper
{
    public static class LiftState
    {
        private static FloorPlan? floorValue;
        private static Direction directionValue;
        private static State stateValue;

        public static FloorPlan FloorValue
        {
            set => floorValue = value;
            get => floorValue;
        }

        public static Direction DirectionValue
        {
            set => directionValue = value;
            get => directionValue;
        }

        public static State StateValue
        {
            set => stateValue = value;
            get => stateValue;
        }
    }
}