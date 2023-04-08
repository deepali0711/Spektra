import { ComponentFixture, TestBed } from '@angular/core/testing';

import { page1Component } from './page1.component';

describe('Page1Component', () => {
  let component: page1Component;
  let fixture: ComponentFixture<page1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ page1Component ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(page1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
