import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ISkillGenre } from 'src/app/interfaces/iskill-genre';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-adminskills',
  templateUrl: './adminskills.component.html',
  styleUrls: ['./adminskills.component.css']
})
export class AdminskillsComponent implements OnInit {

  skillsForm = new FormGroup({
    skillsId: new FormControl()
  });
  public skillslist: ISkillGenre[] = [];

  constructor(private api: ApiService) { }

  ngOnInit(): void {
    this.getSkills();
  }

  getSkills() {
    this.api.getAllSkills().subscribe(data => {
      console.log(data);
      this.skillslist = data;
    });
  }

  editSkill(Obj: ISkillGenre) {
    window.localStorage.setItem('skillId', Obj.skillsId);
  }

  deleteSkills(Obj: ISkillGenre) {
    this.api.deleteSkill(Obj.skillsId).subscribe(data => {
      let foundItem = this.skillslist.findIndex(({skillsId}) => skillsId = Obj.skillsId);
      this.skillslist.splice(foundItem, 1);
    });
  }

}
