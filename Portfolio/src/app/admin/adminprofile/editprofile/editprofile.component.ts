import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { IContact } from 'src/app/interfaces/icontact';
import { ILocation } from 'src/app/interfaces/ilocation';
import { IProfile } from 'src/app/interfaces/iprofile';
import { IStatus } from 'src/app/interfaces/istatus';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-editprofile',
  templateUrl: './editprofile.component.html',
  styleUrls: ['./editprofile.component.css']
})
export class EditprofileComponent implements OnInit {

  editForm = new FormGroup({
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
  profile: IProfile = {};

  constructor(private api: ApiService, private router: Router) { }

  ngOnInit(): void {
    this.getLocations();
    this.getStatus();
    this.getContact();
    this.getProfile();
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

  getProfile() {
    this.api.getSingleProfileData(window.localStorage.getItem('id')).subscribe(obj =>
      {
        this.profile = obj;
        //console.log(this.profile);
      }
      );
  }

  profileHandler(profileObj: IProfile) {
    this.api.saveProfile(profileObj).subscribe(data =>
      {
        //console.log(data);
        this.router.navigate(['admin/profile']);
      });
  }

}
