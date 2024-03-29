import { Component, OnInit } from '@angular/core';
import { IEducation } from 'src/app/interfaces/ieducation';
import { ISkillGenre } from 'src/app/interfaces/iskill-genre';
import { IWork } from 'src/app/interfaces/iwork';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  constructor(private api: ApiService) { }

  work: IWork[] = [];
  education: IEducation[] = [];
  skills: ISkillGenre[] = [];
  workCount: Number = 0;
  visitorsCount: Number = 0;
  educationCount: Number = 0;
  skillCount: Number = 0;

  ngOnInit(): void {
    this.getWork();
    this.getEducation();
    this.getSkills();
  }

  getWork() {
    this.api.getWorkData().subscribe(data => {
      this.work = data;
      if(this.work == null || this.work == undefined) {
        this.workCount = 0;
      } else {
        this.workCount = this.work.length;
      }

    });
  }

  getEducation() {
    this.api.getEducationData().subscribe(data => {
      this.education = data;
      if(this.education == null || this.education == undefined) {
        this.educationCount = 0;
      } else {
        this.educationCount = this.education.length;
      }
    });
  }

  getSkills() {
    this.api.getAllSkills().subscribe(data => {
      this.skills = data;
      if(this.skills == null || this.skills == undefined) {
        this.skillCount = 0;
      } else {
        this.skillCount = this.skills.length;
      }
    });
  }

}
