namespace ClassesIntro {
    public class Car {

        // Private fields
        //lower camel case prefixed by an underscore 
        //no custom get set
        //fields are very similar to properties but are convention private
        //this is a blueprint of a car
        private int _milesDriven;

        private int _milesAtLastService;

        //Color, Make, and Model are all strings so they must be declared
        //if you only have a get that is a read only property
        //will either have both get set or just get
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        //computed property
        public string Description {
            get {
                //inside you can declare variables and do whatever you want

                return $"A {Year} {Color} {Make} {Model}";
            }
        }

        // Methods is a fancy word for function
        // First step is to say whether public or private
        // Void is what type of method it returns (void doesn't return)
        public void Drive (int miles) {
            _milesDriven += miles;
        }

        public int GetOdometer () {
            return _milesDriven;
        }

        public void Service () {
            _milesAtLastService = -_milesDriven;
        }

        public int GetMaintenanceAtMileage () {
            return _milesAtLastService + 5000;
        }

        //Constructor Method
        //give it an accessibility
        //constructor method does not have a return type
        //the name of the method is the same as the calss
        //this method is what's going to be invoked when calling the class
        //great place to put defaults for values
        //constructors can take parameters
        public Car (int year, int miles) {
            Year = ;
            _milesAtLastService = 10000;
        }

    }
}