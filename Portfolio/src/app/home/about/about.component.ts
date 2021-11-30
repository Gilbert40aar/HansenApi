import { devOnlyGuardedExpression } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { IProfile } from 'src/app/interfaces/iprofile';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.css']
})
export class AboutComponent implements OnInit {

  profile: IProfile = {}
  birthday: any;
  age: any;
  constructor(private api: ApiService) { }

  ngOnInit(): void {
    this.getProfileData();
  }

  getProfileData() {
    this.api.getMyProfileData().subscribe(data => {
      this.profile = data;
      this.calculateAge(data.birthDay)
    });
  }

  reverseBirthday(str: string) {
    let birth = "";
    for(var i = str.length - 1; i >= 0; i--) {
      birth += str[i];
    }
    return birth;
  }

  calculateAge(birthday: any) {
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
