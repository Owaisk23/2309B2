import 'package:flutter/material.dart';
import 'package:firstproject/Screens/drawerSide.dart' as drawerSide;


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
      drawer: drawerSide.DrawerSide(),
      body:  Padding(
        // padding: const EdgeInsets.all(20),
        // padding: const EdgeInsets.only(top: 30, left: 15, right: 20, bottom: 45),
        padding: const EdgeInsets.symmetric(vertical: 25, horizontal: 10),
        child: Center(
          child: ListView(
            // mainAxisAlignment: MainAxisAlignment.start,
            // mainAxisAlignment: MainAxisAlignment.center,
            // mainAxisAlignment: MainAxisAlignment.end,
            // mainAxisAlignment: MainAxisAlignment.spaceAround,
            // mainAxisAlignment: MainAxisAlignment.spaceBetween,
            // mainAxisAlignment: MainAxisAlignment.spaceEvenly,
            children: [
              Container(
                height: 100,
                width: 100,
                color: Colors.blue,
                child:  Icon(Icons.home, color: Colors.white, size: 50),
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
              SizedBox(height: 10),
              Container(
                height: 100,
                width: 100,
                color: Colors.deepPurple,
                child: Icon(Icons.wheelchair_pickup, color: Colors.white, size: 50),
              ),
              SizedBox(height: 10),
              Container(
                height: 100,
                width: 100,
                color: Colors.black,
                child: Icon(Icons.u_turn_left, color: Colors.white, size: 50),
              ),
            ],
          ),
        ),
      ),
      
      // body: SingleChildScrollView(
      //   scrollDirection: Axis.vertical,
      // child: Center(
      //   child: Column(
      //     // mainAxisAlignment: MainAxisAlignment.start,
      //     // mainAxisAlignment: MainAxisAlignment.center,
      //     // mainAxisAlignment: MainAxisAlignment.end,
      //     // mainAxisAlignment: MainAxisAlignment.spaceAround,
      //     // mainAxisAlignment: MainAxisAlignment.spaceBetween,
      //     // mainAxisAlignment: MainAxisAlignment.spaceEvenly,
      //     children: [
      //       Container(
      //         height: 100,
      //         width: 100,
      //         color: Colors.blue,
      //         child:  Icon(Icons.home, color: Colors.white, size: 50),
      //       ),
      //       SizedBox(height: 10),
      //       Container(
      //         height: 100,
      //         width: 100,
      //         color: Colors.red,
      //         child: Icon(Icons.contact_emergency, color: Colors.white, size: 50),
      //       ),
      //       SizedBox(height: 10),
      //       Container(
      //         height: 100,
      //         width: 100,
      //         color: Colors.deepOrange,
      //         child: Icon(Icons.phone, color: Colors.white, size: 50),
      //       ),
      //       SizedBox(height: 10),
      //       Container(
      //         height: 100,
      //         width: 100,
      //         color: Colors.green,
      //         child: Icon(Icons.wheelchair_pickup, color: Colors.white, size: 50),
      //       ),
      //       SizedBox(height: 10),
      //       Container(
      //         height: 100,
      //         width: 100,
      //         color: Colors.brown,
      //         child: Icon(Icons.u_turn_left, color: Colors.white, size: 50),
      //       ),
      //       SizedBox(height: 10),
      //       Container(
      //         height: 100,
      //         width: 100,
      //         color: Colors.deepPurple,
      //         child: Icon(Icons.wheelchair_pickup, color: Colors.white, size: 50),
      //       ),
      //       SizedBox(height: 10),
      //       Container(
      //         height: 100,
      //         width: 100,
      //         color: Colors.black,
      //         child: Icon(Icons.u_turn_left, color: Colors.white, size: 50),
      //       ),
      //     ],
      //   ),
      // ),
      // )
    );
  }
}
