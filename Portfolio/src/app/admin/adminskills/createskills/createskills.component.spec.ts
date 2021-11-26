import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateskillsComponent } from './createskills.component';

describe('CreateskillsComponent', () => {
  let component: CreateskillsComponent;
  let fixture: ComponentFixture<CreateskillsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateskillsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateskillsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
