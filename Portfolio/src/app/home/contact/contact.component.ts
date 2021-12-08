import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { IMessage } from 'src/app/interfaces/imessage';
import { IProfile } from 'src/app/interfaces/iprofile';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {

  contactForm = new FormGroup({
    fullName: new FormControl(),
    email: new FormControl(),
    subject: new FormControl(),
    message: new FormControl(),
    readOrNot: new FormControl(1),
    sendDate: new FormControl(new Date())
  });

  profile: IProfile = {};

  constructor(private api: ApiService, private router: Router) { }

  ngOnInit(): void {
    this.getProfile();
  }

  getProfile() {
    this.api.getMyProfileData().subscribe(data => {
      this.profile = data;
    })
  }

  sendMailHandler(mailObj: IMessage) {
    this.api.saveMessage(mailObj).subscribe(data => {
      this.router.navigate(['./home']);
    })
  }

}
