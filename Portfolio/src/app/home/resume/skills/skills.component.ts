import { Component, Input, OnInit } from '@angular/core';
import { ISkillGenre } from 'src/app/interfaces/iskill-genre';

@Component({
  selector: 'app-skills',
  templateUrl: './skills.component.html',
  styleUrls: ['./skills.component.css']
})
export class SkillsComponent implements OnInit {

  @Input() skill: ISkillGenre = {};

  constructor() { }

  ngOnInit(): void {
  }

}
