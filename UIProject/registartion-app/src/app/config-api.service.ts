import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class ConfigApiService {
  headerDict = {
    'Content-Type': 'application/json',
    'Access-Control-Allow-Headers': 'Content-Type',
  };

  requestOptions = {
    headers: new HttpHeaders(this.headerDict),
  };

  constructor(private httpClient: HttpClient) {}

  sendFormData(userData: any) {
    return this.httpClient.post(
      'http://localhost:5108/api/Registration',
      userData,
      this.requestOptions
    );
  }
}
