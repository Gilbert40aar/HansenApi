import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { IProfile } from 'src/app/interfaces/iprofile';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-adminprofile',
  templateUrl: './adminprofile.component.html',
  styleUrls: ['./adminprofile.component.css']
})
export class AdminprofileComponent implements OnInit {

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

  public birthday: any;
  public age: any;

  ngOnInit(): void {
    this.getProfile();
    console.log(this.profile);

    //this.getSingleProfile();
    //console.log(this.profile);
  }

  getProfile() {
    this.api.getMyProfileData().subscribe(obj => {
      //console.log(obj)
      this.profile = obj;
      console.log('HEJ: ', this.profile);
      this.calculateAge(obj.birthDay);
    });
    //console.log(this.profile);

  }

  /* getSingleProfile() {
    this.api.getSingleProfileData(window.localStorage.getItem('id')).subscribe(data => {
      this.profile = data;
      this.calculateAge(data.birthDay);
    });
  } */

  calculateAge(birthday: any) {
    let birth: Date = new Date(birthday);
    let today = new Date();
    let dob = new Date(birthday);
    let year = today.getFullYear() - dob.getFullYear();
    let month = today.getMonth() - dob.getMonth();
    if(month < 0 || (month === 0 && today.getDate() < dob.getDate())) {
      year--;
    }
    this.age = year;
    const months = new Array();
      months[0] = "January";
      months[1] = "February";
      months[2] = "March";
      months[3] = "April";
      months[4] = "May";
      months[5] = "June";
      months[6] = "July";
      months[7] = "August";
      months[8] = "September";
      months[9] = "October";
      months[10] = "November";
      months[11] = "December";

      this.birthday = dob.getDate()+' '+months[dob.getUTCMonth()]+' '+dob.getFullYear();
  }
}
