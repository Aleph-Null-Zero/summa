import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';

// Importa las páginas que creamos
import 'features/auth/login_page.dart';
import 'features/dashboard/dashboard_page.dart';

class MyApp extends ConsumerWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return MaterialApp(
      title: 'SUMMA',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      // En lugar de home: ... usamos rutas:
      initialRoute: '/login',
      routes: {
        '/login': (_) => const LoginPage(),
        '/dashboard': (_) => const DashboardPage(),
      },
    );
  }
}
