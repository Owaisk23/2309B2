import 'dart:convert' as CONVERT;
import 'package:http/http.dart' as HTTP;

void main() async{
  print("Dart API Fetch");

  final API = Uri.parse("https://67d13a6e825945773eb37cfc.mockapi.io/dev/students");

  HTTP.get(API).then((response) {
    if (response.statusCode == 200) {
      final data = CONVERT.jsonDecode(response.body);
      // print(data);
      List<dynamic> studentsInfo = data;
      for (var student in studentsInfo) {
        print("Student Name: ${student['name']}");
        print("Student Avatar: ${student['avatar']}");
        print("Student Age: ${student['age']}");
        print("Student Age: ${student['country']}");
        print("================================================================");
      }
    
    } else {
      print("Error: ${response.statusCode}");
    }
 
  });




  
  // final response = await http.get(API);
  // print(response.body);



}