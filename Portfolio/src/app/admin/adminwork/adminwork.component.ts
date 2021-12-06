import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { IWork } from 'src/app/interfaces/iwork';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-adminwork',
  templateUrl: './adminwork.component.html',
  styleUrls: ['./adminwork.component.css']
})
export class AdminworkComponent implements OnInit {

  worklist: IWork[] = [];
  editForm = new FormGroup({
    workId: new FormControl()
  });

  constructor(private api: ApiService, private router: Router) { }

  ngOnInit(): void {
    this.getWork();
  }

  getWork() {
    return this.api.getWorkData().subscribe(obj => {this.worklist = (obj); console.log(obj)});
  }

  editWork(obj: IWork) {
    console.log(obj);

    window.localStorage.setItem('workId', obj.workId);
  }

  deleteWork(obj: IWork) {
    this.api.deletework(obj.workId).subscribe(data => {
      let foundWork = this.worklist.findIndex(({workId}) => workId = obj.workId);
      this.worklist.splice(foundWork, 1);
    });
  }

}
