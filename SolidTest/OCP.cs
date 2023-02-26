namespace SolidTest
{
    public interface IUploadOrderFile
    {
        object ProcessOrderFile();
    }

    public class UploadXMLOrderFile : IUploadOrderFile
    {
        public object ProcessOrderFile()
        {
            object orderObj = null;

            //Parse XML File to DTO Object

            return orderObj;
        }
    }

    public class UploadProcess
    {
        public bool UploadFile()
        {
            IUploadOrderFile orderFile = null;

            //if XML File
            {
                orderFile = new UploadXMLOrderFile();
            }

            //if JSON File
            {
                orderFile = new UploadJSONOrderFile();
            }

            Object orderObj = orderFile.ProcessOrderFile();

            //Validate Records

            //Save Records

            return true;
        }
    }
    public class UploadJSONOrderFile : IUploadOrderFile
    {
        public object ProcessOrderFile()
        {
            object orderObj = null;

            //Parse JSON File to DTO Object

            return orderObj;
        }
    }
}
