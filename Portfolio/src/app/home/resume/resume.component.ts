import { Component, OnInit } from '@angular/core';
import { IEducation } from 'src/app/interfaces/ieducation';
import { ISkillGenre } from 'src/app/interfaces/iskill-genre';
import { IWork } from 'src/app/interfaces/iwork';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-resume',
  templateUrl: './resume.component.html',
  styleUrls: ['./resume.component.css']
})
export class ResumeComponent implements OnInit {

  education: IEducation[] = [];
  works: IWork[] = [];
  skills : ISkillGenre[] = [];

  constructor(private api: ApiService) { }

  ngOnInit(): void {
    this.getAllEducation();
    this.getAllWork();
    this.getAllSkills();
  }

  getAllEducation() {
    this.api.getEducationData().subscribe(data => this.education = data);
  }

  getAllWork() {
    this.api.getWorkData().subscribe(data => this.works = data);
  }

  getAllSkills() {
    this.api.getAllSkills().subscribe(data => this.skills = data);
  }

}
