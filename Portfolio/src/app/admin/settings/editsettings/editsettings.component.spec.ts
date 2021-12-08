import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditsettingsComponent } from './editsettings.component';

describe('EditsettingsComponent', () => {
  let component: EditsettingsComponent;
  let fixture: ComponentFixture<EditsettingsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditsettingsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditsettingsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
