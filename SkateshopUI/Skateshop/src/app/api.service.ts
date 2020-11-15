import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'; // From Angular Library
import { StateService } from './state.service';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private httpClient: HttpClient,
    private stateservice: StateService) {
  }


  clickedLogIn(username: string, password: string) {
    // const guid = uuid();
    // var headers = new HttpHeaders({
    //   'x-ms-refid': guid
    // });
    // const date = new Date().toISOString();
    const body = {
      UserName: username,
      Password: password,
      LogInIndicator: false
    };
    return this.httpClient.post<any>(`http://localhost/SkateshopApi/api/User/login`, body);
  }
}
