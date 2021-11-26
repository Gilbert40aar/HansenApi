import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { IStatus } from 'src/app/interfaces/istatus';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-profilestatus',
  templateUrl: './profilestatus.component.html',
  styleUrls: ['./profilestatus.component.css']
})
export class ProfilestatusComponent implements OnInit {

  statusForm = new FormGroup({
    work: new FormControl(),
    employee: new FormControl()
  });

  constructor(private api: ApiService) { }

  ngOnInit(): void {
  }

  statusHandler(statusObj: IStatus) {
    console.log(statusObj);
    this.api.saveStatus(statusObj).subscribe(data => console.log(data));
  }

}
