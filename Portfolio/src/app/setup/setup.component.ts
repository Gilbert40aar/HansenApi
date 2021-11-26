import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { IAdmin } from '../interfaces/iadmin';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-setup',
  templateUrl: './setup.component.html',
  styleUrls: ['./setup.component.css']
})
export class SetupComponent implements OnInit {



  setupForm = new FormGroup({
    userName: new FormControl(),
    passWord: new FormControl(),
    firstName: new FormControl(),
    lastName: new FormControl()
  });

  constructor(private api: ApiService, private router: Router) { }

  ngOnInit(): void {
  }



  submitHandler(adminObj: IAdmin) {

    let admin: IAdmin = {
      userName: adminObj.userName,
      passWord: adminObj.passWord,
      firstName: adminObj.firstName,
      lastName: adminObj.lastName
    }
    //console.log(data);
    this.api.saveAdmin(adminObj).subscribe(data => {
      console.log(data)
      this.router.navigate(['./login']);
    });
  }

}
