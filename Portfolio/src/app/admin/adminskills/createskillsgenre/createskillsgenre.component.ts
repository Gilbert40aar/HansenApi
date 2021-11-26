import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { ISkillGenre } from 'src/app/interfaces/iskill-genre';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-createskillsgenre',
  templateUrl: './createskillsgenre.component.html',
  styleUrls: ['./createskillsgenre.component.css']
})
export class CreateskillsgenreComponent implements OnInit {

  genreForm = new FormGroup({
    skillsTitle: new FormControl()
  });

  constructor(private api: ApiService, private router: Router) { }

  ngOnInit(): void {
  }

  skillGenreHandler(genreObj: ISkillGenre) {
    this.api.saveSkills(genreObj).subscribe(data => console.log(data));
  }

}
