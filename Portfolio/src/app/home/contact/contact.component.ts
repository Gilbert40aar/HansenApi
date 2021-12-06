import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
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
    message: new FormControl()
  });

  profile: IProfile = {};

  constructor(private api: ApiService) { }

  ngOnInit(): void {
    this.getProfile();
  }

  getProfile() {
    this.api.getMyProfileData().subscribe(data => {
      this.profile = data;
    })
  }

}
