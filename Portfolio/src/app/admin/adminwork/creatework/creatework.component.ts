import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { IWork } from 'src/app/interfaces/iwork';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-creatework',
  templateUrl: './creatework.component.html',
  styleUrls: ['./creatework.component.css']
})
export class CreateworkComponent implements OnInit {

  workForm = new FormGroup({
    workTitle: new FormControl(),
    company: new FormControl(),
    addRess: new FormControl(),
    zipCode: new FormControl(),
    city: new FormControl(),
    startDate: new FormControl(),
    endDate: new FormControl(),
    descripTion: new FormControl()
  });

  constructor(private api: ApiService, private router: Router) { }

  ngOnInit(): void {
  }

  workHandler(workObj: IWork) {
    return this.api.saveWork(workObj).subscribe(data => {console.log(data);
    this.router.navigate(['admin/work']);
    });
  }

}
