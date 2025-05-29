import 'package:flutter/material.dart';

class BoxlistView extends StatefulWidget {
  const BoxlistView({Key? key}) : super(key: key);

  @override
  _BoxlistViewState createState() => _BoxlistViewState();
}

class _BoxlistViewState extends State<BoxlistView> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Box List View'),
        backgroundColor: Colors.black,
        foregroundColor: Colors.white,
        centerTitle: true,
      ),
      body: Center(
        child: Column(
          children: [
            Container(
              height: 100,
              width: 100,
              color: Colors.blue,
              child: Icon(Icons.home, color: Colors.white, size: 50),
            ),
            SizedBox(height: 10),
            Container(
              height: 100,
              width: 100,
              color: Colors.red,
              child: Icon(Icons.contact_emergency, color: Colors.white, size: 50),
            ),
            SizedBox(height: 10),
            Container(
              height: 100,
              width: 100,
              color: Colors.deepOrange,
              child: Icon(Icons.phone, color: Colors.white, size: 50),
            ),
            SizedBox(height: 10),
            Container(
              height: 100,
              width: 100,
              color: Colors.green,
              child: Icon(Icons.wheelchair_pickup, color: Colors.white, size: 50),
            ),
            SizedBox(height: 10),
            Container(
              height: 100,
              width: 100,
              color: Colors.brown,
              child: Icon(Icons.u_turn_left, color: Colors.white, size: 50),
            ),
          ],
        ),
      ),
    );
  }
}
