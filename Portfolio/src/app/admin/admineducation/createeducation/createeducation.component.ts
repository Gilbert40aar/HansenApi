import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { IEducation } from 'src/app/interfaces/ieducation';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-createeducation',
  templateUrl: './createeducation.component.html',
  styleUrls: ['./createeducation.component.css']
})
export class CreateeducationComponent implements OnInit {

  eduForm = new FormGroup({
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

  constructor(private api: ApiService, private router: Router) { }

  ngOnInit(): void {
  }

  educationHandler(eduObj: IEducation) {
    this.api.saveEducation(eduObj).subscribe(data => {
      this.router.navigate(['admin/education']);
    })
  }

}
