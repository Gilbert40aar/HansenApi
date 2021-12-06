import { Component, Input, OnInit, Output } from '@angular/core';
import { IProjects } from 'src/app/interfaces/iprojects';

@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.css']
})
export class ProjectComponent implements OnInit {

  @Input() project: IProjects = {};

  constructor() { }

  ngOnInit(): void {
  }

  showModal(id: any) {
    console.log("showModal is clicked...");
  }

}
