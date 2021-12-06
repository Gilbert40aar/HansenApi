import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { IProjects } from 'src/app/interfaces/iprojects';

@Component({
  selector: 'app-adminproject',
  templateUrl: './adminproject.component.html',
  styleUrls: ['./adminproject.component.css']
})
export class AdminprojectComponent implements OnInit {

  projectForm = new FormGroup({
    projectId: new FormControl()
  });

  projectlist: IProjects[] = [];

  constructor() { }

  ngOnInit(): void {
  }

  editProject(projectObj: IProjects) {

  }

  deleteProject(projectObj: IProjects) {

  }

}
