import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { ApiService } from './api.service';
import { LoginComponent } from './login/login.component';
import { StateService } from './state.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  // @ViewChild(LoginComponent) loggedUser;

  // loggedIn: boolean;

  title = 'Skateshop';
  loggedIn: boolean;
  // loggedUser: boolean;
  constructor(public stateService: StateService,
    private apiService: ApiService) { // Inject the stateService
    // console.log(this.stateService.loggedIn);
    // this.loggedIn = this.stateService.loggedIn;
    this.loggedIn = this.stateService.loggedUser;
    console.log("this.loggedIn " + this.loggedIn);
  }

  // ngAfterViewInit() {
  //   this.loggedUser = this.login.message
  // }


}
