import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { IContact } from 'src/app/interfaces/icontact';
import { ILocation } from 'src/app/interfaces/ilocation';
import { IProfile } from 'src/app/interfaces/iprofile';
import { IStatus } from 'src/app/interfaces/istatus';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-createprofile',
  templateUrl: './createprofile.component.html',
  styleUrls: ['./createprofile.component.css']
})
export class CreateprofileComponent implements OnInit {

  profileForm = new FormGroup({
    firstName: new FormControl(),
    secondName: new FormControl(),
    lastName: new FormControl(),
    locationId: new FormControl(),
    statusId: new FormControl(),
    contactId: new FormControl(),
    birthDay: new FormControl(),
    descripTion: new FormControl()
  });

  location: ILocation[] = [];
  status: IStatus[] = [];
  contact: IContact[] = [];

  constructor(private api: ApiService, private router: Router) { }

  ngOnInit(): void {
    this.getLocations();
    this.getStatus();
    this.getContact();
  }

  getLocations() {
    this.api.getLocationData().subscribe(data => {this.location = (data);});
  }

  getStatus() {
    this.api.getStatusData().subscribe(staobj => {this.status = (staobj);});
  }

  getContact() {
    this.api.getContactData().subscribe(conobj => {this.contact = (conobj);});
  }

  profileHandler(profileObj: IProfile) {
    this.api.saveProfile(profileObj).subscribe(data =>
      {
        console.log(data);
        this.router.navigate(['admin/profile']);
      });
  }

}
