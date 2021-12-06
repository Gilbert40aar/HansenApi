import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { IEducation } from 'src/app/interfaces/ieducation';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-editeducation',
  templateUrl: './editeducation.component.html',
  styleUrls: ['./editeducation.component.css']
})
export class EditeducationComponent implements OnInit {

  eduForm = new FormGroup({
    educationId: new FormControl(),
    educationTitle: new FormControl(),
    school: new FormControl(),
    addRess: new FormControl(),
    zipCode: new FormControl(),
    city: new FormControl(),
    startDate: new FormControl(),
    endDate: new FormControl(),
    courses: new FormControl(),
    internship: new FormControl(),
    descripTion: new FormControl()
  });

  edu: IEducation = {};

  constructor(private api: ApiService, private router: Router) { }

  ngOnInit(): void {
    this.getEducation(window.localStorage.getItem('educationId'));
  }

  getEducation(id: any) {
    this.api.getSingleEducationData(id).subscribe(data => this.eduForm.setValue(data));
  }

  educationHandler(eduObj: IEducation) {
    this.api.updateEducation(eduObj).subscribe(data => {
      window.localStorage.removeItem('educationId');
      this.router.navigate(['admin/education']);
    });

  }

}
