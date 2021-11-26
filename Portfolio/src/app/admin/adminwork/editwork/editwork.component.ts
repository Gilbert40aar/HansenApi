import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { IWork } from 'src/app/interfaces/iwork';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-editwork',
  templateUrl: './editwork.component.html',
  styleUrls: ['./editwork.component.css']
})
export class EditworkComponent implements OnInit {

  workForm = new FormGroup({
    workTitle: new FormControl(),
    company: new FormControl(),
    addRess: new FormControl(),
    zipCode: new FormControl(),
    city: new FormControl(),
    startDate: new FormControl(),
    endDate: new FormControl(),
    descripTion: new FormControl()
  });

  work: IWork = {};

  constructor(private api: ApiService, private router: Router) { }

  ngOnInit(): void {
    this.getWork(window.localStorage.getItem('workId'));
  }

  getWork(id: any) {
    this.api.getSingleWorkData(id).subscribe(obj => {this.work = obj; console.log(this.work)});
  }

  workHandler(workObj: IWork) {
    window.localStorage.removeItem('workId');
    this.router.navigate(['admin/work']);
  }

}
