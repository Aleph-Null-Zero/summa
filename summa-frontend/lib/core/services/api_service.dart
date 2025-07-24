import 'package:http/http.dart' as http;
class ApiService {
  final String baseUrl;
  ApiService({required this.baseUrl});
  Future<http.Response> get(String endpoint) async {
    final url = Uri.parse('\$baseUrl\$endpoint');
    return await http.get(url);
  }
}