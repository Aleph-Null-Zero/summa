import 'package:hive_flutter/hive_flutter.dart';
class DBService {
  static Future init() async {
    await Hive.initFlutter();
  }
}