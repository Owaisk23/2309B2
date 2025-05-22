import 'package:http/http.dart' as http;

void main() async{
  print("Dart API Fetch");

  final API = Uri.parse("https://67d13a6e825945773eb37cfc.mockapi.io/dev/students");
  final response = await http.get(API);
  print(response.body);



}