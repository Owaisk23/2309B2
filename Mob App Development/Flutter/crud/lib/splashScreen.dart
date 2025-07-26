import 'dart:async';

import 'package:crud/products.dart';
import 'package:flutter/material.dart';

class SplashScreen extends StatefulWidget {
  const SplashScreen({ Key? key }) : super(key: key);

  @override
  _SplashScreenState createState() => _SplashScreenState();
}

class _SplashScreenState extends State<SplashScreen> {
  void initState() {
    super.initState();
    Timer(Duration(seconds: 3), () {
      // Navigator.pushReplacementNamed(context, "/products");
      // Navigator.pushReplacement(context, MaterialPageRoute(builder: (context)=>Products()));
      Navigator.pushNamed(context, "/signup");
    });
  }   

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.deepPurple,
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Icon(Icons.flutter_dash, size: 100, color: Colors.white,),
            Text(
              "My App",
              style: TextStyle(
                fontSize: 30,
                fontWeight: FontWeight.bold,
                color: Colors.white
              ),)
          ],
        ),
      ),
    );
  }
}