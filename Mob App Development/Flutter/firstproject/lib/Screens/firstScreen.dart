import 'package:flutter/material.dart';
import 'package:firstproject/Screens/drawerSide.dart' as drawerSide;

class FirstScreen extends StatefulWidget {
  const FirstScreen({ Key? key }) : super(key: key);

  @override
  _FirstScreenState createState() => _FirstScreenState();
}

class _FirstScreenState extends State<FirstScreen> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('First Screen'),
        backgroundColor: Colors.black,
        foregroundColor: Colors.white,
        centerTitle: true,
      ),
      drawer: drawerSide.DrawerSide(),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Image.network('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT5ilihiQWied-urDIQFLy0h6p7bR8RNjMXuQ&s',
              height: 200,
              width: 500,
            ),
            SizedBox(height: 30,),
            Text(
              'Welcome to the Cow Mandi',
              style: TextStyle(fontSize: 24, fontWeight: FontWeight.bold),
            ),
            Text(
              'Welcome to the first screen of our app! Here you can find various features and functionalities that will enhance your experience.', textAlign: TextAlign.center,
              style: TextStyle(fontSize: 18, color: Colors.grey[600]),
            ),
          ],
        ),
      ),
    );
  }
}