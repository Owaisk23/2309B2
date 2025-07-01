import 'package:device_preview/device_preview.dart';
import 'package:firstproject/Screens/BillCalculator.dart';
import 'package:firstproject/Screens/firstScreen.dart';
// import 'package:firstproject/Screens/product.dart';
// import 'package:firstproject/Screens/userProfile.dart';
import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';

void main() => runApp(
  DevicePreview(
    enabled: !kReleaseMode,
    builder: (context) => MyApp(), // Wrap your app
  ),
);

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      locale: DevicePreview.locale(context),
      builder: DevicePreview.appBuilder,
      theme: ThemeData.light(),
      darkTheme: ThemeData.dark(),
      home: BillCalculator(),
    );
  }
}