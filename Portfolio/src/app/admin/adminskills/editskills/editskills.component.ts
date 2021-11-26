import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { ISkillGenre } from 'src/app/interfaces/iskill-genre';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-editskills',
  templateUrl: './editskills.component.html',
  styleUrls: ['./editskills.component.css']
})
export class EditskillsComponent implements OnInit {

  skillsForm = new FormGroup({
    skillsTitle: new FormControl(),
    skillsIcon: new FormControl(),
    skillsPoints: new FormControl()
  });

  skill: ISkillGenre = {};

  constructor(private api: ApiService, private router: Router) { }

  ngOnInit(): void {
    this.getSkillData(window.localStorage.getItem('skillsId'));
  }

  getSkillData(id: any) {
    this.api.getSingleSkillData(id).subscribe(obj => {
      this.skill = obj;
    });
  }

  skillsHandler(skillObj: ISkillGenre) {
    console.log(skillObj);
    window.localStorage.removeItem('skillsId');
    this.router.navigate(['admin/skills']);
  }

}
