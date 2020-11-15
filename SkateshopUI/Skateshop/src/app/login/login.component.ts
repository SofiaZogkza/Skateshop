import { Component, EventEmitter, OnInit, Output, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ApiService } from '../api.service';
import { StateService } from '../state.service';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner'
import { $ } from 'protractor';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {
  // @Output() loggedUser: EventEmitter<any> = new EventEmitter();
  loginForm: FormGroup;
  loggedIn: boolean;
  loggedUser: boolean;
  loggedOutUser: boolean;
  systemErrorMessage: string;
  showModal: boolean;
  @ViewChild('loggedIn') loggedInModal: any;
  constructor(
    private fb: FormBuilder,
    private stateService: StateService,
    private apiService: ApiService,
    private router: Router
  ) {
    this.loginForm = this.createForm();
  }

  ngOnInit(): void {
  }

  createForm() {
    return this.fb.group({
      username: ['', {
        validators: [
          Validators.required,
          Validators.pattern(/[\\\^\/\,\.]$/)
        ],
        updateOn: 'blur'
      }],
      password: ['', {
        validators:
          [
            Validators.required,
            Validators.pattern(/[\\\^\/\,\.]$/),
          ],
        updateOn: 'blur'
      }]
    });
  }
  loggedOut($event: boolean) {
    this.loggedOutUser = $event;
    if (this.loggedOutUser) {
      this.router.navigate(['/']);
    }
  }
  logIn() {
    this.stateService.toggleLoggedIn();
    this.loggedIn = this.stateService.loggedIn;
    this.apiService.clickedLogIn(this.loginForm.value.username, this.loginForm.value.password).subscribe(
      res => {
        this.loggedIn = res.Success;
        this.systemErrorMessage = res.ErrorMessage;
        if (res.Success === false) {
          this.showModal = true;
          // $('#myModal').modal('show');
        }
        // this.loggedUser.emit(this.loggedIn);
        this.stateService.loggedUser = true;
        this.loggedUser = this.stateService.loggedUser;
        console.log(res);
      }
    );
  }


}

