import { Component, Input, OnInit } from '@angular/core';
import { IProjects } from 'src/app/interfaces/iprojects';

@Component({
  selector: 'app-works',
  templateUrl: './works.component.html',
  styleUrls: ['./works.component.css']
})
export class WorksComponent implements OnInit {

  projects: IProjects[] = [];
  constructor() { }

  ngOnInit(): void {
  }

}
