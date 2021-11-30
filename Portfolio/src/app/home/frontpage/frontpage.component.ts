import { Component, OnInit } from '@angular/core';
import { IProfile } from 'src/app/interfaces/iprofile';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-frontpage',
  templateUrl: './frontpage.component.html',
  styleUrls: ['./frontpage.component.css']
})
export class FrontpageComponent implements OnInit {

  profile: IProfile = {};

  constructor(private api: ApiService) { }

  ngOnInit(): void {
    this.getMyProfile();
  }

  getMyProfile() {
    this.api.getMyProfileData().subscribe(obj => this.profile = obj);
  }

}
