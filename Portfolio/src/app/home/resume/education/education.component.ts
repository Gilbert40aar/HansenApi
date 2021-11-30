import { Component, Input, OnInit } from '@angular/core';
import { IEducation } from '../../../interfaces/ieducation';

@Component({
  selector: 'app-education',
  templateUrl: './education.component.html',
  styleUrls: ['./education.component.css']
})
export class EducationComponent implements OnInit {

  @Input() education: IEducation = {};

  constructor() { }

  ngOnInit(): void {
  }

}
