namespace ApplicationLogic
{
    public class Controller
    {
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Controller();
                }

                return instance;
            }
        }

        private Controller() { }


    }
}
