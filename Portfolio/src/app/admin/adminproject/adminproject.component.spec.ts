import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminprojectComponent } from './adminproject.component';

describe('AdminprojectComponent', () => {
  let component: AdminprojectComponent;
  let fixture: ComponentFixture<AdminprojectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminprojectComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminprojectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
