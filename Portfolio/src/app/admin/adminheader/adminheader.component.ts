import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { IMessage } from 'src/app/interfaces/imessage';
import { ApiService } from 'src/app/services/api.service';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-adminheader',
  templateUrl: './adminheader.component.html',
  styleUrls: ['./adminheader.component.css']
})
export class AdminheaderComponent implements OnInit {

  public fullname : string = '';

  isRead: any = '1';

  messages: IMessage[] = [];
  count: number = 0;

  constructor(private api: ApiService, private auth: AuthService, private router: Router) {
    this.auth.OnLogoutSuccessful.subscribe(next => {
      this.router.navigate(['../home/frontpage']);
    });
  }

  ngOnInit(): void {
    this.getfullName();
  }

  getMessages() {
    return null;
  }

  getfullName() {
    if(this.auth.fullname != null) {
      this.fullname = this.auth.fullname;
    } else {
      this.fullname = 'Ray Palmer';
    }
  }

  settingsHandler() {
    this.router.navigate(['admin/settings']);
  }

  logoutHandler() {
    this.auth.logout();
  }

}
