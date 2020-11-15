import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StateService {
  loggedIn: boolean;
  loggedUser: boolean;
  constructor() {

  }
  toggleLoggedIn() {
    this.loggedIn = !this.loggedIn;
  }
}