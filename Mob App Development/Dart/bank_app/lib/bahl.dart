class BAHL {
  // Private variables
  num _accountBalance = 1300;
  //Operations
  //1. Deposit
  void deposit(num amount) {
    //Error handling using try-catch
    try {
      if (amount <= 0) {
        throw Exception('Deposit amount must be greater than zero.');
      } else {
        _accountBalance += amount;
        // _accountBalance = _accountBalance + amount;
        print('Deposit successful. New balance: $_accountBalance');
      }
    } catch (e) {
      print('Error: ${e.toString()}');
    }
  }
  //2. Withdraw
   void withdraw(num amount){
    try{
      if(amount <= 0){
        throw Exception("Invalid amount.");
      }
      else if(amount > _accountBalance){
        throw Exception("Insufficient balance.");
      }
      else{
        _accountBalance -= amount;
        print("Amount Withdrawn Successfully!");
      }
    }
    catch(e){
      print("Error: $e");
    }
  }
  //3. Balance Inquiry
  void balanceInquiry(){
    //Error handling using try-catch
    try {
      if (_accountBalance <= 0) {
        throw Exception('Insufficient balance.');
      } else {
        print('Current balance: $_accountBalance');
      }
    } catch (e) {
      print('Error: ${e.toString()}');
    }
  }

}
