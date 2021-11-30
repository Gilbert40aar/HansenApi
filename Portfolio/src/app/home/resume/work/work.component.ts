import { Component, Input, OnInit } from '@angular/core';
import { IWork } from 'src/app/interfaces/iwork';

@Component({
  selector: 'app-work',
  templateUrl: './work.component.html',
  styleUrls: ['./work.component.css']
})
export class WorkComponent implements OnInit {

  @Input() work: IWork = {};

  constructor() { }

  ngOnInit(): void {
  }

}
