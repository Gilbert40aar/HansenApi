import { Component, OnInit } from '@angular/core';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-settings',
  templateUrl: './settings.component.html',
  styleUrls: ['./settings.component.css']
})
export class SettingsComponent implements OnInit {

  constructor(private api: ApiService) { }

  isSettings: boolean = false;

  ngOnInit(): void {
    this.getSettings();
  }

  getSettings() {
    this.api.getSettings().subscribe(data => {
      //console.log(data);
      if(data == null) {
        this.isSettings = true;
      } else {
        this.isSettings = false;
      }
      /*if(data.length != 0) {
        this.isSettings = true;
      }
      this.isSettings = false;*/
      console.log('Settings: ', this.isSettings);
    })
  }

}
