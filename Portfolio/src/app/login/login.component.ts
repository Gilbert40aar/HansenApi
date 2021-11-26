import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { IAdmin } from '../interfaces/iadmin';
import { ILogin } from '../interfaces/ilogin';
import { ApiService } from '../services/api.service';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginForm = new FormGroup({
    username: new FormControl(),
    password: new FormControl()
  });

  constructor(private api: ApiService, private auth: AuthService, private router: Router) {
    this.auth.OnLoginSuccessful.subscribe(next => {
      if (this.auth.authenticated) router.navigate(['admin/dashboard']);
    });
  }

  ngOnInit(): void {
  }

  loginHandler(login: ILogin) {
    this.auth.login(login);
  }

  onLoginSuccessful() {

  }

}
