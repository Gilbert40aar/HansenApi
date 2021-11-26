import { Component, OnInit } from '@angular/core';
import { ISkillGenre } from 'src/app/interfaces/iskill-genre';

@Component({
  selector: 'app-resume',
  templateUrl: './resume.component.html',
  styleUrls: ['./resume.component.css']
})
export class ResumeComponent implements OnInit {

  public skills : ISkillGenre[] = [];

  constructor() { }

  ngOnInit(): void {
  }

}
