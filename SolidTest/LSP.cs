namespace SolidTest
{
    public abstract class MotorInsurance
    {
        public abstract bool IssuePolicy();

        public virtual bool GetPassengerCover()
        {
            return false;
        }
    }

    public class TwoWheelerInsurance : MotorInsurance
    {
        public override bool IssuePolicy()
        {
            //Logic to Issue & Generate Policy

            return true;
        }
    }

    public class PrivateCarInsurance : MotorInsurance
    {
        public override bool IssuePolicy()
        {
            //Logic to Issue & Generate Policy

            return true;
        }
    }

    public class CommercialVehicleInsurance : MotorInsurance
    {
        public override bool IssuePolicy()
        {
            //Logic to Issue & Generate Policy

            return true;
        }

        public override bool GetPassengerCover()
        {
            return true;
        }
    }
}
