import { ValueConverter } from '@angular/compiler/src/render3/view/template';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { ISkillGenre } from 'src/app/interfaces/iskill-genre';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-createskills',
  templateUrl: './createskills.component.html',
  styleUrls: ['./createskills.component.css']
})
export class CreateskillsComponent implements OnInit {

  skillsForm = new FormGroup({
    skillsTitle: new FormControl(),
    skillsIcon: new FormControl(),
    skillsPoints: new FormControl()
  });

  dataViews = null;
  constructor(private router: Router, private api: ApiService) { }

  ngOnInit(): void {
  }

  skillsHandler(skillsObj: ISkillGenre) {
    this.api.saveSkills(skillsObj).subscribe(data => {
      this.router.navigate(['./admin/skills']);
    });
  }

}
