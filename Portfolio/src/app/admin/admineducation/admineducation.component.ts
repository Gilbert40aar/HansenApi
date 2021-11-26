import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { IEducation } from 'src/app/interfaces/ieducation';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-admineducation',
  templateUrl: './admineducation.component.html',
  styleUrls: ['./admineducation.component.css']
})
export class AdmineducationComponent implements OnInit {

  editForm = new FormGroup({
    educationId: new FormControl()
  });
  educationlist: IEducation[] = [];
  constructor(private api: ApiService, private router: Router) { }

  ngOnInit(): void {
    this.getEducations();
  }

  getEducations() {
    return this.api.getEducationData().subscribe(data => {
      this.educationlist = data;
    })
  }

  editEducation(obj: IEducation) {
    window.localStorage.setItem('educationId', obj.educationId);
  }

  deleteEducation(obj: IEducation) {
    this.api.deleteEducation(obj.educationId).subscribe(data => {
      let foundEducation = this.educationlist.findIndex(({educationId}) => educationId = obj.educationId);
      this.educationlist.splice(foundEducation, 1);
    })
  }
}
