import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { IContact } from 'src/app/interfaces/icontact';
import { ILocation } from 'src/app/interfaces/ilocation';
import { IProfile } from 'src/app/interfaces/iprofile';
import { IStatus } from 'src/app/interfaces/istatus';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-adminprofile',
  templateUrl: './adminprofile.component.html',
  styleUrls: ['./adminprofile.component.css']
})
export class AdminprofileComponent implements OnInit {

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
  profiles: IProfile[] = [];
  public profileCount = '';


  constructor(private api: ApiService, private router: Router) { }

  /*public firstName = null;
  public secondName = null;
  public lastName = null;
  public locationId = null;
  public contactId = null;
  public statusId = null;
  public birthDay = null;
  public descripTion = null;*/

  ngOnInit(): void {
    this.getLocations();
    this.getStatus();
    this.getContact();
    this.getProfile();
    this.getProfileCount();
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
    this.api.getProfileData(window.localStorage.getItem('id')).subscribe(obj =>
      {
        this.profile = (obj);
        //console.log(obj)
      }
      );
  }

  profileHandler(profileObj: IProfile) {
    this.api.saveProfile(profileObj).subscribe(data =>
      {
        console.log(data);
        this.router.navigate(['admin/dashboard']);
      });
  }

  getProfileCount() {
    this.api.getProfileCount().subscribe(data => {
      this.profiles = data;
      //console.log(this.profiles);
      this.profileCount = this.profiles.length.toString();
      //console.log(this.profileCount);
    });
  }



}
