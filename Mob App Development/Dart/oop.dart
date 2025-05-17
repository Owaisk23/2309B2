class Car{
  // Properties && Variables
  String? carBrand, carModel,carName, carColor;

  //default constructor
  Car(String carBrand, String carModel, String carName, String carColor){
    this.carBrand = carBrand;
    this.carModel = carModel;
    this.carName = carName;
    this.carColor = carColor;
  }
  //named constructor
  Car.carWithoutColor(String carBrand, String carModel, String carName){
    this.carBrand = carBrand;
    this.carModel = carModel;
    this.carName = carName;
  }

  //methods or functions
  void carDetails(){
    print("Car Brand: $carBrand");
    print("Car Model: $carModel");
    print("Car Name: $carName");
    print("Car Color: $carColor");
  }

}

void main(){
  print("Object Oriented Programming");

  //creating object of class
  Car         car1     = Car("Honda", "RS Turbo", "Honda Civic", "Black");
  Car         car2     = Car("Toyota", "Grande", "Toyota Carolla", "White");
//classNAme  objName     Constructor
  car1.carDetails();
  print("===================================");
  car2.carDetails();


}